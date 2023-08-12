using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using shop.Data.Context;
using shop.Data.Entities;
using shop.Utilities.Exceptions;
using shop.ViewModels.Common;
using shop.ViewModels.System.Users;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace shop.Application.System.Users;

public class UserServices : IUserServices
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly RoleManager<AppRole> _roleManager;
    private readonly IConfiguration _config;
    private readonly ShopDbContext _context;

    public UserServices(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IConfiguration config, ShopDbContext context)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
        _config = config;
        _context = context;
    }

    public async Task<ApiResult<string>> Authencate(LoginRequest request)
    {
        var user = await _userManager.FindByNameAsync(request.UserName);
        if (user == null) return new ApiErrorResult<string>("Tài khoản không tồn tại");

        var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
        if (!result.Succeeded)
        {
            return new ApiErrorResult<string>("Đăng nhập không đúng");
        }
        var roles = await _userManager.GetRolesAsync(user);
        var claims = new[]
        {

                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.FirstName),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.Name, request.UserName),
                //new Claim("userId", user.Id.ToString())
                
        };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(_config["Tokens:Issuer"],
            _config["Tokens:Issuer"],
            claims,
            expires: DateTime.Now.AddHours(3),
            signingCredentials: creds);

        return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
    }
    public async Task<ApiResult<string>> AuthencateCustomer(LoginRequest request)
    {
        var user = await _userManager.FindByNameAsync(request.UserName);
        if (user == null) return new ApiErrorResult<string>("Tài khoản không tồn tại");

        var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
        if (!result.Succeeded)
        {
            return new ApiErrorResult<string>("Đăng nhập không đúng");
        }
        var roles = await _userManager.GetRolesAsync(user);
        var claims = new[]
        {

                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.FirstName),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.Name, request.UserName),
                new Claim("userId", user.Id.ToString())

        };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(_config["Tokens:Issuer"],
            _config["Tokens:Issuer"],
            claims,
            expires: DateTime.Now.AddHours(3),
            signingCredentials: creds);

        return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
    }

    public async Task<ApiResult<bool>> Delete(Guid id)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
        {
            return new ApiErrorResult<bool>("User không tồn tại");
        }
        var reult = await _userManager.DeleteAsync(user);
        if (reult.Succeeded)
            return new ApiSuccessResult<bool>($"Xóa user có id {id} thành công");

        return new ApiErrorResult<bool>("Xóa không thành công");
    }

    public async Task<UserVm> GetById(Guid id)
    {
        var user = await _userManager.FindByIdAsync(id.ToString()) ?? throw new ShopException("User không tồn tại");
        var roles = await _userManager.GetRolesAsync(user);
        var userVm = new UserVm()
        {
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            FirstName = user.FirstName,
            Dob = user.DoB,
            Id = user.Id,
            LastName = user.LastName,
            UserName = user.UserName,
            Roles = roles
        };
        return userVm;
    }

    public async Task<PagedResult<UserVm>> GetStaffPaging(GetUserPagingRequest request)
    {
        int totalRow;

        // var query = _userManager.Users;
        var role = await _roleManager.FindByNameAsync("employee");
        var users = await _userManager.GetUsersInRoleAsync(role.Name);
        if (!string.IsNullOrEmpty(request.Keyword))
        {
            users = users.Where(x => x.UserName.Contains(request.Keyword) || x.PhoneNumber.Contains(request.Keyword)).ToList();
            totalRow = users.Count();
        }

        //3. Paging
        //int totalRow = await query.CountAsync();
        totalRow = users.Count();
        var data = users.Skip((request.PageIndex - 1) * request.PageSize)
            .Take(request.PageSize)
            .Select(x => new UserVm()
            {
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                UserName = x.UserName,
                FirstName = x.FirstName,
                Dob = x.DoB,
                Id = x.Id,
                LastName = x.LastName
            });


        //4. Select and projection
        var pagedResult = new PagedResult<UserVm>()
        {
            TotalRecords = totalRow,
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
            Items = data.ToList()
        };
        return pagedResult;
    }

    public async Task<PagedResult<UserVm>> GetCustomerPaging(GetUserPagingRequest request)
    {
        int totalRow;

        // var query = _userManager.Users;
        var role = await _roleManager.FindByNameAsync("customer");
        var users = await _userManager.GetUsersInRoleAsync(role.Name);
        if (!string.IsNullOrEmpty(request.Keyword))
        {
            users = users.Where(x => x.UserName.Contains(request.Keyword) || x.PhoneNumber.Contains(request.Keyword)).ToList();
            totalRow = users.Count();
        }

        //3. Paging
        //int totalRow = await query.CountAsync();
        totalRow = users.Count();
        var data = users.Skip((request.PageIndex - 1) * request.PageSize)
            .Take(request.PageSize)
            .Select(x => new UserVm()
            {
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                UserName = x.UserName,
                FirstName = x.FirstName,
                Dob = x.DoB,
                Id = x.Id,
                LastName = x.LastName
            });



        //4. Select and projection
        var pagedResult = new PagedResult<UserVm>()
        {
            TotalRecords = totalRow,
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
            Items = data.ToList()
        };
        return pagedResult;
    }

    public async Task<ApiResult<bool>> RegisterEmployee(RegisterRequest request)
    {
        var user = await _userManager.FindByNameAsync(request.UserName);
        if (user != null)
        {
            return new ApiErrorResult<bool>("Tài khoản đã tồn tại");
        }
        if (await _userManager.FindByEmailAsync(request.Email) != null)
        {
            return new ApiErrorResult<bool>("Emai đã tồn tại");
        }

        user = new AppUser()
        {
            DoB = request.Dob,
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            UserName = request.UserName,
            PhoneNumber = request.PhoneNumber
        };
        var result = await _userManager.CreateAsync(user, request.Password);
        //var role = _config["Role"];
        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, "employee");
            return new ApiSuccessResult<bool>("Đăng ký thành công");
        }
        return new ApiErrorResult<bool>("Đăng ký không thành công");
    }

    public async Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
        {
            return new ApiErrorResult<bool>("Tài khoản không tồn tại");
        }
        var removedRoles = request.Roles.Where(x => x.Selected == false).Select(x => x.Name).ToList();
        foreach (var roleName in removedRoles)
        {
            if (await _userManager.IsInRoleAsync(user, roleName) == true)
            {
                await _userManager.RemoveFromRoleAsync(user, roleName);
            }
        }
        await _userManager.RemoveFromRolesAsync(user, removedRoles);

        var addedRoles = request.Roles.Where(x => x.Selected).Select(x => x.Name).ToList();
        foreach (var roleName in addedRoles)
        {
            if (await _userManager.IsInRoleAsync(user, roleName) == false)
            {
                await _userManager.AddToRoleAsync(user, roleName);
            }
        }

        return new ApiSuccessResult<bool>($"Gán quyền thành công cho user có id {id}");
    }

    public async Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request)
    {
        if (await _userManager.Users.AnyAsync(x => x.Email == request.Email && x.Id != id))
        {
            return new ApiErrorResult<bool>("Emai đã tồn tại");
        }
        var user = await _userManager.FindByIdAsync(id.ToString());
        user.DoB = request.Dob;
        user.Email = request.Email;
        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.PhoneNumber = request.PhoneNumber;

        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded)
        {
            return new ApiSuccessResult<bool>($"Xóa user có id {id} thành công");
        }
        return new ApiErrorResult<bool>("Cập nhật không thành công");
    }

    public async Task<ApiResult<bool>> RegisterCustomer(RegisterRequest request)
    {
        var user = await _userManager.FindByNameAsync(request.UserName);
        if (user != null)
        {
            return new ApiErrorResult<bool>("Tài khoản đã tồn tại");
        }
        if (await _userManager.FindByEmailAsync(request.Email) != null)
        {
            return new ApiErrorResult<bool>("Emai đã tồn tại");
        }

        user = new AppUser()
        {
            DoB = request.Dob,
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            UserName = request.UserName,
            PhoneNumber = request.PhoneNumber
        };
        var result = await _userManager.CreateAsync(user, request.Password);
        var giohang = new Cart()
        {
            UserId = user.Id,
            Description = user.UserName
        };
        await _context.Carts.AddAsync(giohang);
        if (result.Succeeded)
        {

            await _userManager.AddToRoleAsync(user, "customer");

            return new ApiSuccessResult<bool>("Đăng ký thành công");
        }
        return new ApiErrorResult<bool>("Đăng ký không thành công");
    }
}
