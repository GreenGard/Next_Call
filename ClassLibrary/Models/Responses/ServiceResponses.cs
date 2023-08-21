using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Responses
{
    public class ServiceResponses
    {

        public static ServiceResponse<T> ServiceResponseStatusCode200<T>(ServiceResponse<T> serviceResponse, T data)
        {
            serviceResponse.StatusCode = 200;
            serviceResponse.Success = true;
            serviceResponse.Data = data;

            return serviceResponse;
        }

        public static ServiceResponse<T> ServiceResponseStatusCode200NoData<T>(ServiceResponse<T> serviceResponse)
        {
            serviceResponse.StatusCode = 200;
            serviceResponse.Success = true;

            return serviceResponse;
        }
        public static ServiceResponse<T> ServiceResponseStatusCode200WithMessage<T>(ServiceResponse<T> serviceResponse, T data, string functionName)
        {
            serviceResponse.StatusCode = 200;
            serviceResponse.Success = true;
            serviceResponse.Data = data;
            serviceResponse.Message = functionName;

            return serviceResponse;
        }

        public static ServiceResponse<T> ServiceResponseStatusCode400<T>(ServiceResponse<T> serviceResponse, string message)
        {
            serviceResponse.StatusCode = 400;
            serviceResponse.Success = false;
            serviceResponse.Message = message;

            return serviceResponse;
        }

        public static ServiceResponse<T> ServiceResponseStatusCode404<T>(ServiceResponse<T> serviceResponse, string message)
        {
            serviceResponse.StatusCode = 404;
            serviceResponse.Success = false;
            serviceResponse.Message = message;

            return serviceResponse;
        }

        public static ServiceResponse<T> ServiceResponseStatusCode429<T>(ServiceResponse<T> serviceResponse, string message)
        {
            serviceResponse.StatusCode = 429;
            serviceResponse.Success = false;
            serviceResponse.Message = message;

            return serviceResponse;
        }

        public static ServiceResponse<T> ServiceResponseStatusCode500<T>(ServiceResponse<T> serviceResponse, string message)
        {
            serviceResponse.StatusCode = 500;
            serviceResponse.Success = false;
            serviceResponse.Message = message;

            return serviceResponse;
        }
    }
}
