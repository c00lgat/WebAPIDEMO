var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

// Routing

// "/proteins"
app.MapGet("/proteins", () =>
{
    return "Reading Proteins"; //Returns an array of JSONS where each JSON describes a protein
    //Usually not a good idea to put all the code inside this function, instead, create
    //classes and functions to handle different operations
});

app.MapGet("/proteins/{id}", (int id) =>
{
    return $"Reading Protein with ID: {id}"; 
});

app.MapPost("/proteins", () =>
{
    return "Creating a Protein.";
});

app.MapPut("/proteins/{id}", (int id) =>
{
    return $"Updating protein with ID: {id}";
});

app.MapDelete("/proteins/{id}", (int id) =>
{
    return $"Deleting Protein with ID: {id}";
});


app.Run();

