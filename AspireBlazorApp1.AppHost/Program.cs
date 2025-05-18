var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireBlazorApp_ApiService>("aspireblazorapp-apiservice");

builder.Build().Run();
