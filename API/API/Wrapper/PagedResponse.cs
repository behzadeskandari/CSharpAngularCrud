namespace API.Wrapper
{
    public class PagedResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }


        public PagedResponse(T data, int pageNumber, int pageSize,int _totalRecords)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Data = data;
            this.Message = null;
            this.Succeeded = true;
            this.Errors = null;
            this.TotalRecords = _totalRecords;
            if(this.TotalRecords % 10 == 0)
            {
                this.TotalPages = _totalRecords / 10;
            }
            else
            {
                this.TotalPages = (_totalRecords / 10) + 1;
            }

        }
    }
}
