
@{
    ViewBag.Title = "Login";
}
@{
    for (int i = 1; i <= 5; i++)
    {
        <h2>
            Iteration: @i, Current Date and Time is:
            @DateTime.Now.ToString()
        </h2>
    }
}
<h1>This view was rendered at: @DateTime.Now.ToString()</h1>
<h2>Login</h2>


