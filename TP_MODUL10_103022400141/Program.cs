var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// === TAMBAHKAN 2 BARIS INI ===
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// (Optional) Baris bawaan AddOpenApi() bisa dihapus atau di-comment
// builder.Services.AddOpenApi(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // === TAMBAHKAN 2 BARIS INI ===
    app.UseSwagger();
    app.UseSwaggerUI();

    // (Optional) Baris bawaan MapOpenApi() bisa dihapus atau di-comment
    // app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();