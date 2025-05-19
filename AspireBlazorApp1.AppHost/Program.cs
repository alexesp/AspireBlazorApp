var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.AspireBlazorApp_ApiService>("aspireblazorapp-apiservice");

builder.AddProject<Projects.AspireBlazorApp_Web>("aspireblazorapp-web")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
