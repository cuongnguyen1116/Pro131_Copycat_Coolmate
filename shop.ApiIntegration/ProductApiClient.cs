using Newtonsoft.Json;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Colors;
using shop.ViewModels.Catalog.Materials;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Catalog.Sizes;
using shop.ViewModels.Common;
using System.Text;

namespace shop.ApiIntegration
{
    public class ProductApiClient : IProductApiClient
    {

        public ProductApiClient()
        {

        }
        public async Task<ApiResult<bool>> CategoryAssign(Guid id, CategoryAssignRequest request)
        {
            var httpClient = new HttpClient();
            string apiURL = $"https://localhost:5000/api/Products/productProp/{id}/categories";
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync(apiURL, httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<bool> CreateProduct(ProductCreateRequest request, Guid productPropId, Guid sizeId, Guid colorId, Guid materialId)
        {
            var httpClient = new HttpClient();
            string apiURL = "https://localhost:5000/api/Products/create/";

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
            request.ProductId = productPropId;
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

            var response = await httpClient.PostAsync(apiURL, requestContent);
            return response.IsSuccessStatusCode;
        }
        //Bảng  product
        public async Task<bool> CreateProductProp(ProductPropVm request)
        {
            var httpClient = new HttpClient();
            string url = $"https://localhost:5000/api/Products/createproductprop/";
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, httpContent);
            return response.IsSuccessStatusCode;

        }

        public async Task<bool> DeleteProduct(ProductDeleteRequest request)
        {
            var httpClient = new HttpClient();
            string apiURL = $"https://localhost:5000/api/Products/delete/{request.Id}";
            var response = await httpClient.DeleteAsync(apiURL);
            return response.IsSuccessStatusCode;

        }
        //Bảng  product
        public async Task<bool> DeleteProductProp(ProductPropVm request)
        {
            var httpClient = new HttpClient();
            string apiURL = $"https://localhost:5000/api/Products/deleteProductProp/{request.Id}";
            var response = await httpClient.DeleteAsync(apiURL);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<ProductVm>> GetAll()
        {
            var httpClient = new HttpClient();
            string apiURL = "https://localhost:5000/api/Products/";

            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<ProductVm>>(apiData);
            return result;
        }


        public async Task<ProductVm> GetById(Guid productDetailId)
        {
            var httpClient = new HttpClient();

            string apiURL = $"https://localhost:5000/api/Products/product/{productDetailId}";
            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ProductVm>(apiData);
            return result;
        }
        //Bảng  product
        public async Task<ProductPropVm> GetByIdProductProp(Guid productPropId)
        {
            var httpClient = new HttpClient();

            string apiURL = $"https://localhost:5000/api/Products/productprop/{productPropId}";
            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ProductPropVm>(apiData);
            return result;
        }

        public async Task<List<ColorVm>> GetListColor()
        {
            var httpClient = new HttpClient();
            string apiURL = "https://localhost:5000/api/Colors/";

            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<ColorVm>>(apiData);
            return result;
        }

        public async Task<List<MaterialVm>> GetListMaterial()
        {
            var httpClient = new HttpClient();
            string apiURL = "https://localhost:5000/api/Materials/";

            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<MaterialVm>>(apiData);
            return result;
        }

        public async Task<List<ProductPropVm>> GetListProductProp()
        {
            var httpClient = new HttpClient();
            string apiURL = "https://localhost:5000/api/Products/propductprops";
            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<ProductPropVm>>(apiData);
            return result;
        }

        public async Task<List<SizeVm>> GetListSize()
        {
            var httpClient = new HttpClient();
            string apiURL = "https://localhost:5000/api/Sizes/";

            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<SizeVm>>(apiData);
            return result;
        }

        public async Task<bool> UpdateProduct(ProductUpdateRequest request)
        {
            var httpClient = new HttpClient();
            string apiURL = $"https://localhost:5000/api/Products/update/{request.Id}";

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

            requestContent.Add(new StringContent(request.Price.ToString()), "price");
            requestContent.Add(new StringContent(request.Stock.ToString()), "stock");
            requestContent.Add(new StringContent(request.Status.ToString()), "status");

            var response = await httpClient.PutAsync(apiURL, requestContent);
            return response.IsSuccessStatusCode;

        }
        //Bảng  product
        public async Task<bool> UpdateProductProp(ProductPropVm request)
        {
            var httpClient = new HttpClient();
            string url = $"https://localhost:5000/api/Products/updateProductProp/{request.Id}";
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(url, httpContent);
            return response.IsSuccessStatusCode;
        }
    }
}
