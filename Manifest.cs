using OrchardCore.Modules.Manifest;

[assembly: Module(
    Author = "Etch UK Ltd.",
    Category = "Content",
    Description = "Simplify creating press kits for games industry.",
    Name = "Press Kit",
    Version = "0.3.0",
    Website = "https://etchuk.com",
    Dependencies = new string[] { "Etch.OrchardCore.Blocks" }
)]