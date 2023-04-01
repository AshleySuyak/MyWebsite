# MyWebsite
dotnet build newHealth.sln -c Release -t:Rebuild
dotnet public newHealth.sln -c Release --output "package"
cd newHealth
npm run startup.cs
