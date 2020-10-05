using Microsoft.AspNetCore.Http;

namespace Refactored.This.API.Core
{
    public static class Extensions
    {
        /// <summary>
        /// To add pagination info to Response headers
        /// </summary>
        /// <param name="response"></param>
        /// <param name="currentPage"></param>
        /// <param name="itemsPerPage"></param>
        /// <param name="totalItems"></param>
        /// <param name="totalPages"></param>
        public static void AddPagination(this HttpResponse response, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            response.Headers.Add("Pagination",
               Newtonsoft.Json.JsonConvert.SerializeObject(paginationHeader));
            response.Headers.Add("access-control-expose-headers", "Pagination");
        }

        /// <summary>
        /// To make the error not look ugly
        /// </summary>
        /// <param name="response"></param>
        /// <param name="message"></param>
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("access-control-expose-headers", "Application-Error");
        }
    }
}
