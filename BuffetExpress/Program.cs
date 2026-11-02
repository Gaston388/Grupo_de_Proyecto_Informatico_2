using Persistencia.Entidades;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
     app.MapOpenApi();
    app.UseSwaggerUI(options =>
     options.SwaggerEndpoint("/openapi/v1.json", "v1"));
}


 List<Producto>productos=new List<Producto>();
{
    productos.Add(new Producto{ Id = 1, Nombre = "chuchi", Descripcion = "arroz, algas, salmon y queso", Precio = 1200, Categoria = "Comidas" });
    productos.Add(new Producto{ Id = 2, Nombre = "Empanada de Carne", Descripcion = "Empanada casera", Precio = 450, Categoria = "Comidas" });
    productos.Add(new Producto{ Id = 3, Nombre = "Coca-Cola 500ml", Descripcion = "Bebida gaseosa", Precio = 600, Categoria = "Bebidas" });
    productos.Add(new Producto{ Id = 4, Nombre = "Agua Mineral", Descripcion = "Agua sin gas", Precio = 400, Categoria = "Bebidas" });
    productos.Add(new Producto{ Id = 5, Nombre = "Alfajor", Descripcion = "Alfajor de dulce de leche", Precio = 350, Categoria = "Postres" });
};

app.MapGet("/Producto", () =>
{
    return Results.Ok(productos);
});
app.UseHttpsRedirection();
app.Run();
