namespace shop.ViewModels.Common;

public class ApiSuccessResult<T> : ApiResult<T>
{
    //public ApiSuccessResult()
    //{
    //    IsSuccessed = true;
    //}
    public ApiSuccessResult(T resultObj)
    {
        IsSuccessed = true;
        ResultObj = resultObj;
    }

    public ApiSuccessResult(string message)
    {
        IsSuccessed = true;
        Message = message;
    }
}
