using NRGsystemsProgrammer.Services;
using NRGSystemsWebSite.Components;
using NRGSystemsWebSite.Components.Pages.MessagesReports;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

builder.Services.AddSweetAlert2();

builder.Services.AddSingleton<FunctionRestService>();
builder.Services.AddSingleton<ClientRestFunctionServices>();
builder.Services.AddSingleton<ExerciseRestFunction>();


builder.Services.AddSingleton<CommentsColumn>();
builder.Services.AddSingleton<ProgramExerciseList>();

//var storageConnection = builder.Configuration["DefaultEndpointsProtocol=https;AccountName=nrgsystemsblobacc;AccountKey=rJwBToVd3JWXphreBb480JxbrwD9LLx4I4SrXr/sfXo4BIZGgnV6yFz82llB1Z3N6rgxbA2xbR9q+AStJ2s5lg==;EndpointSuffix=core.windows.net"];
builder.Services.AddAzureClients(azureBuilder =>
{
    azureBuilder.AddBlobServiceClient("DefaultEndpointsProtocol=https;AccountName=nrgptappstorage;AccountKey=iTPlcqLUuBSbUPzwqdv76Wa7LQ4wyPjiUthrjC+cIVMh0DLtjZsAUcDU5KAyAeVx52qOXGv0BTWP+ASt39/Meg==;EndpointSuffix=core.windows.net");
    //azureBuilder.AddBlobServiceClient("DefaultEndpointsProtocol=https;AccountName=nrgsystemsblobacc;AccountKey=rJwBToVd3JWXphreBb480JxbrwD9LLx4I4SrXr/sfXo4BIZGgnV6yFz82llB1Z3N6rgxbA2xbR9q+AStJ2s5lg==;EndpointSuffix=core.windows.net");
});

builder.Services.AddBlazorBootstrap();
//builder.Services.AddHttpClient("api", httpClient => httpClient.BaseAddress = new Uri("http://localhost:5186/"));

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
