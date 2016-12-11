using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;



namespace NorthwindServices
{
    [ServiceContract]
    public interface IProducts
    {
        [OperationContract] 
        //[WebInvoke(Method = "GET", 
        //    ResponseFormat = WebMessageFormat.Json, 
        //    BodyStyle = WebMessageBodyStyle.Wrapped,
        //    UriTemplate = "GetProductName/{productID}")]
        string GetProductName(int productID);

        [OperationContract]
        int GetProductQty(int productID);

        [OperationContract]
        string GetCategoryName(int productID);

        [OperationContract]
        string GetName();

        [OperationContract]
        string GetDateTime();
    }
}
