namespace BlazorApp6.Client;
public static class ApiUtils
{
    public static string GetEndpoint<T>()
    {
        return typeof(T).FullName!;
    }

    //public static string GetGroup<THandler>()
    //{
    //    return typeof(THandler).FullName.Split('.');
    //}
}

//public static class ModuleEndpoints
//{
//   public static class Person
//    {

//    }
//}
