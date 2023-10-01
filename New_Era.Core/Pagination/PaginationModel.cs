namespace New_Era.Core.Pagination
{
    public class PaginationModel<T>
    {
        public int ItemForPage { get; set; }
        public int TotalItems { get; set; }
        public int Page { get; set; }
        public int TotalPage => (int)Math.Ceiling((decimal)TotalItems / ItemForPage);
        public bool HasPrivous => Page > 1 ? true : false;
        public bool HasNext => Page < TotalPage ? true : false;
        public bool success { get; set; }
        public T Data { get; set; }
    }
}
