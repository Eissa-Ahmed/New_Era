namespace New_Era.Data.Router
{
    public static class Router
    {
        private const string Api = "api/";
        public static class StudentRouter
        {
            private const string BaseRoute = Api + "Student/";
            public const string GetAllAsync = BaseRoute + "GetAllAsync";
            public const string GetByIdAsync = BaseRoute + "GetByIdAsync";
            public const string Delete = BaseRoute + "Delete";
            public const string AddAsync = BaseRoute + "AddAsync";
            public const string UpdateAsync = BaseRoute + "UpdateAsync";
        }
    }
}
