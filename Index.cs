@model IEnumerable<ASPNET_Assignment.Models.Product>
@{
    ViewBag.Title = "Index";
}
<h2>Product list as on: @DateTime.Now.ToString()</h2>
@{
    foreach (var p in Model)
    {
        <h2>Product Id: @p.ProductId</h2>
        <h3>Product Name: @p.ProductName</h3>
        <h3>Price: @p.Price</h3>
        <hr />
    }
}



