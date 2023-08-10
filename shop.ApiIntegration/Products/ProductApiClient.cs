﻿using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Colors;
using shop.ViewModels.Catalog.Materials;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Catalog.Sizes;
using shop.ViewModels.Common;
using System.Text;

namespace shop.ApiIntegration.Products;

public class ProductApiClient : BaseApiClient, IProductApiClient
{

    public ProductApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
    {

    }
    public async Task<ApiResult<bool>> CategoryAssign(Guid id, CategoryAssignRequest request)
    {
        string apiURL = $"/api/Products/productProp/{id}/categories/";
        var json = JsonConvert.SerializeObject(request);
        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync(apiURL, httpContent);
        response.EnsureSuccessStatusCode();
        string result = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
            return JsonConvert.DeserializeObject<ApiResult<bool>>(result);

        return JsonConvert.DeserializeObject<ApiResult<bool>>(result);
    }
    // Bảng ProductDetail
    public async Task<bool> CreateProductDetail(ProductDetailCreateRequest request, Guid productId, Guid sizeId, Guid colorId, Guid materialId)
    {

        string apiURL = "/api/Products/create-productdetail/";

        var requestContent = new MultipartFormDataContent();

        request.ProductId = productId;
        request.SizeId = sizeId;
        request.ColorId = colorId;
        request.MaterialId = materialId;
        requestContent.Add(new StringContent(request.ProductId.ToString()), "productid");
        requestContent.Add(new StringContent(request.MaterialId.ToString()), "materialid");
        requestContent.Add(new StringContent(request.ColorId.ToString()), "colorid");
        requestContent.Add(new StringContent(request.SizeId.ToString()), "sizeid");
        requestContent.Add(new StringContent(request.Price.ToString()), "price");
        requestContent.Add(new StringContent(request.OriginalPrice.ToString()), "originalPrice");
        requestContent.Add(new StringContent(request.Stock.ToString()), "stock");
        requestContent.Add(new StringContent(request.Status.ToString()), "status");

        var response = await _httpClient.PostAsync(apiURL, requestContent);
        response.EnsureSuccessStatusCode();
        return response.IsSuccessStatusCode;
    }
    public async Task<bool> UpdateProductDetail(ProductDetailUpdateRequest request)
    {

        string apiURL = $"/api/Products/update-productdetail/{request.Id}";

        var requestContent = new MultipartFormDataContent();

        requestContent.Add(new StringContent(request.Price.ToString()), "price");
        requestContent.Add(new StringContent(request.Stock.ToString()), "stock");
        requestContent.Add(new StringContent(request.Status.ToString()), "status");

        var response = await _httpClient.PutAsync(apiURL, requestContent);
        response.EnsureSuccessStatusCode();
        return response.IsSuccessStatusCode;

    }
    //Bảng  product
    public async Task<bool> CreateProduct(ProductRequest request)
    {

        string url = $"/api/Products/createproduct/";
        var requestContent = new MultipartFormDataContent();

        if (request.ThumbnailImage != null)
        {
            byte[] data;
            using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
            {
                data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
            }
            ByteArrayContent bytes = new ByteArrayContent(data);
            requestContent.Add(bytes, "ThumbnailImage", request.ThumbnailImage.FileName);
        }
        requestContent.Add(new StringContent(request.Description.ToString()), "Description");
        requestContent.Add(new StringContent(request.Name.ToString()), "Name");
        requestContent.Add(new StringContent(request.Status.ToString()), "Status");
        var response = await _httpClient.PostAsync(url, requestContent);
        response.EnsureSuccessStatusCode();
        return response.IsSuccessStatusCode;
    }
    // Bảng ProductDetail
    public async Task<bool> DeleteProductDetail(ProductDeleteRequest request)
    {

        string apiURL = $"/api/Products/delete-productdetail/{request.Id}";
        var response = await _httpClient.DeleteAsync(apiURL);
        response.EnsureSuccessStatusCode();
        return response.IsSuccessStatusCode;

    }
    //Bảng  product
    public async Task<bool> DeleteProduct(ProductDeleteRequest request)
    {

        string apiURL = $"/api/Products/deleteProduct/{request.Id}";
        var response = await _httpClient.DeleteAsync(apiURL);
        response.EnsureSuccessStatusCode();
        return response.IsSuccessStatusCode;
    }
    // Bảng ProductDetail
    public async Task<PagedResult<ProductDetailVm>> GetAllProductDetail(ProductPagingRequest request)
    {

        string apiURL = $"/api/Products/productdetails?pageindex={request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}";
        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<PagedResult<ProductDetailVm>>(apiData);
        return result;
    }

    public async Task<PagedResult<ProductRequest>> GetAllProduct(ProductPagingRequest request)
    {

        string apiURL = $"/api/Products/products?pageindex={request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}&categoryId={request.CategoryId}";
        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<PagedResult<ProductRequest>>(apiData);
        return result;
    }

    // Bảng ProductDetail
    public async Task<ProductDetailVm> GetByIdProductDetail(Guid productDetailId)
    {


        string apiURL = $"/api/Products/productdetail/{productDetailId}";
        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ProductDetailVm>(apiData);
        return result;
    }
    //Bảng  product
    public async Task<ProductRequest> GetByIdProduct(Guid productId)
    {


        string apiURL = $"/api/Products/product/{productId}";
        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ProductRequest>(apiData);
        return result;
    }
    // Lấy danh sách màu
    public async Task<List<ColorVm>> GetListColor()
    {

        string apiURL = "/api/Colors/";

        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<ColorVm>>(apiData);
        return result;
    }
    //Lấy danh sách chất liệu
    public async Task<List<MaterialVm>> GetListMaterial()
    {

        string apiURL = "/api/Materials/";

        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<MaterialVm>>(apiData);
        return result;
    }
    //Lấy danh sách tên san phẩm
    public async Task<List<ProductRequest>> GetListProduct()
    {

        string apiURL = "/api/Products/listPropduct";
        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<ProductRequest>>(apiData);
        return result;
    }
    //Lấy danh sách size
    public async Task<List<SizeVm>> GetListSize()
    {

        string apiURL = "/api/Sizes/";

        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<SizeVm>>(apiData);
        return result;
    }
    // Bảng ProductDetail

    //Bảng  product
    public async Task<bool> UpdateProduct(ProductRequest request)
    {

        string url = $"/api/Products/updateProduct/{request.Id}";
        var requestContent = new MultipartFormDataContent();

        if (request.ThumbnailImage != null)
        {
            byte[] data;
            using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
            {
                data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
            }
            ByteArrayContent bytes = new ByteArrayContent(data);
            requestContent.Add(bytes, "ThumbnailImage", request.ThumbnailImage.FileName);
        }

        requestContent.Add(new StringContent(request.Status.ToString()), "Status");
        requestContent.Add(new StringContent(request.Description.ToString()), "Description");
        requestContent.Add(new StringContent(request.Name.ToString()), "Name");

        var response = await _httpClient.PutAsync(url, requestContent);
        response.EnsureSuccessStatusCode();
        return response.IsSuccessStatusCode;
    }

    public async Task<ApiResult<bool>> CreateImage(ProductImageRequest request, Guid productid)
    {
        string apiURL = $"/api/Products/create-image/";

        var requestContent = new MultipartFormDataContent();

        if (request.ImageFile != null)
        {
            byte[] data;
            using (var br = new BinaryReader(request.ImageFile.OpenReadStream()))
            {
                data = br.ReadBytes((int)request.ImageFile.OpenReadStream().Length);
            }
            ByteArrayContent bytes = new(data);
            requestContent.Add(bytes, "ImageFile", request.ImageFile.FileName);
        }
        request.ProductId = productid;
        requestContent.Add(new StringContent(request.Caption.ToString()), "caption");
        requestContent.Add(new StringContent(request.ProductId.ToString()), "productid");
        requestContent.Add(new StringContent(request.SortOrder.ToString()), "SortOrder");
        requestContent.Add(new StringContent(request.IsDefault.ToString()), "isdefault");

        var response = await _httpClient.PostAsync(apiURL, requestContent);
        response.EnsureSuccessStatusCode();

        string result = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
            return JsonConvert.DeserializeObject<ApiResult<bool>>(result);

        return JsonConvert.DeserializeObject<ApiResult<bool>>(result);
    }

    public async Task<List<ProductVm>> GetFeaturedProducts(int take)
    {
        string apiURL = $"/api/Products/featured/{take}";
        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<ProductVm>>(apiData);
        return result;
    }

    public async Task<List<ProductVm>> GetRecentProducts(int take)
    {
        string apiURL = $"/api/Products/recent/{take}";
        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<ProductVm>>(apiData);
        return result;
    }
}
