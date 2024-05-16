using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "ilk mvc denemesi");
//app.MapGet("/iletisim", () => "Ýletisim sayfasý");
//app.MapGet("/about", () => "hakkimizda! sayfasý");
//app.MapGet("/projects", () => "projeler sayfasý");


//app.MapGet("/", async context =>
//{
//	context.Response.ContentType = "text/html; charset=UTF-8";
//	await context.Response.WriteAsync("<a href='iletisim'>Tiklaüðüðü<a/><br/>");
	
//	await context.Response.WriteAsync("<a href='about'>hakkimizda<a/><br/>");
//	await context.Response.WriteAsync("<a href='projects'>projeler<a/><br/>");


//}

//);
app.MapDefaultControllerRoute();
	app.Run();
