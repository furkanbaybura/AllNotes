using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "ilk mvc denemesi");
//app.MapGet("/iletisim", () => "�letisim sayfas�");
//app.MapGet("/about", () => "hakkimizda! sayfas�");
//app.MapGet("/projects", () => "projeler sayfas�");


//app.MapGet("/", async context =>
//{
//	context.Response.ContentType = "text/html; charset=UTF-8";
//	await context.Response.WriteAsync("<a href='iletisim'>Tikla�����<a/><br/>");
	
//	await context.Response.WriteAsync("<a href='about'>hakkimizda<a/><br/>");
//	await context.Response.WriteAsync("<a href='projects'>projeler<a/><br/>");


//}

//);
app.MapDefaultControllerRoute();
	app.Run();
