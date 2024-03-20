
// Automapper 
builder.Services.AddAutoMapper(typeof(Program).Assembly);
/* I WONT NEED TO USE THIS CUSTOM SERVICES */
//builder.Services.AddScoped<FilmMappingService>();

builder.Services.AddDbContext<NetflixCloneDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

var app = builder.Build();