using Business.Abstract;
using Business.Concrete.BaseConcrete.EntityFramework;
using Data.Abstract;
using Data.Concrete.EntityFramework.repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IBagislarBS, BagislarBS>();
builder.Services.AddTransient<IBildirimKullaniciBS, BildirimKullaniciBS>();
builder.Services.AddTransient<IBildirimlerBS,BildirimlerBS>();
builder.Services.AddTransient<IEtkinlikBS,EtkinlikBS>();
builder.Services.AddTransient<IEtkinlikFotograflariBS,EtkinlikFotograflariBS>();
builder.Services.AddTransient<IHaberlerBS,HaberlerBS>();
builder.Services.AddTransient<IKullanicilarBS,KullanicilarBS>();
builder.Services.AddTransient<IKullaniciRolBS,KullaniciRolBS>();
builder.Services.AddTransient<IMakalelerBS,MakalelerBS>();
builder.Services.AddTransient<IMesajlarBS,MesajlarBS>();
builder.Services.AddTransient<IMesajTipBS,MesajTipBS>();
builder.Services.AddTransient<IRollerBS,RollerBS>();
builder.Services.AddTransient<IUyelikAidatlariBS,UyelikAidatlariBS>();
builder.Services.AddTransient<IUyelikDurumuBS,UyelikDurumuBS>();
builder.Services.AddTransient<IYetkilerBS,YetkilerBS>();
builder.Services.AddTransient<IYetkiRolBS,YetkilerRolBS>();
builder.Services.AddTransient<IYorumlarBS,YorumlarBS>();
builder.Services.AddTransient<IYorumTipBS,YorumTipBS>();

builder.Services.AddTransient<IBagislarRepository,EfBagislarRepository>();
builder.Services.AddTransient<IBildirimKullaniciRepository,EfBildirimKullaniciRepository>();
builder.Services.AddTransient<IBildirimlerRepository,EfBildirimlerRepository>();
builder.Services.AddTransient<IEtkinlikRepository,EfEtkinlikRepository>();
builder.Services.AddTransient<IEtkinlikFotograflariRepository,EfEtkinlikFotograflariRepository>();
builder.Services.AddTransient<IHaberlerRepository,EFHaberlerRepository>();
builder.Services.AddTransient<IKullanicilarRepository,EfKullanicilarRepository>();
builder.Services.AddTransient<IKullaniciRolRepository,EfKullaniciRolRepository>();
builder.Services.AddTransient<IMakalelerRepository,EfMakalelerRepository>();
builder.Services.AddTransient<IMesajlarRepository,EfMesajlarRepository>();
builder.Services.AddTransient<IMesajTipRepository,EfMesajTipRepository>();
builder.Services.AddTransient<IRollerRepository,EfRollerRepository>();
builder.Services.AddTransient<IUyelikDurumuRepository,EfUyelikDurumuRepository>();
builder.Services.AddTransient<IUyelikDurumuRepository,EfUyelikDurumuRepository>();
builder.Services.AddTransient<IYetkilerRepository,EfYetkilerRepository>();
builder.Services.AddTransient<IYetkiRolRepository,EfYetkiRolRepository>();
builder.Services.AddTransient<IYorumlarRepository,EfYorumlarRepository>();
builder.Services.AddTransient<IYorumTipRepository,EfYorumTipRepository>();







var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
