using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Json;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MiniProjectRadditDatabase.Service;
using MiniProjectRadditDatabase.Data;
using static System.Formats.Asn1.AsnWriter;
using MiniProjectRaddit.Model;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

// Sætter CORS så API'en kan bruges fra andre domæner
var AllowSomeStuff = "_AllowSomeStuff";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowSomeStuff, builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin();  //set the allowed origin
        });
});
//Tilføj DbContext factory som service.
builder.Services.AddDbContext<DbALLDATAContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("ContextSQLite")));

//Tilføj DataService så den kan bruges i endpoints
builder.Services.AddScoped<DataService>();
var app = builder.Build();








using (var db = app.Services.CreateScope())
{
    //Console.WriteLine($"Database path: {db.DbPath}.");

    //// Create
    //Console.WriteLine("Indsæt et nyt task");
    //db.Add(new Todo("Nu her", false, "gg", new User("Hans")));
    var dataService = db.ServiceProvider.GetRequiredService<DataService>();
    dataService.SeedData();

    //// Read
    //Console.WriteLine("Find det sidste task");
    //var lastTask = db.Todos
    //    .OrderBy(b => b.TodoId)
    //    .Last();
    //Console.WriteLine($"Text: {lastTask.Name}");
}

app.UseHttpsRedirection();
app.UseCors(AllowSomeStuff);


app.MapGet("/api/users", (DataService service) =>
{
    return service.GetUsers();
});


app.MapGet("/api/user/{id}", (DataService service, int id) =>
{
    User user = service.GetUser(id);
    return user != null ? Results.Ok(user) : Results.BadRequest("id out of range check /api/users");
});

app.MapGet("/api/threadPosts", (DataService service) =>
{
    return service.GetThreadPosts().Select(t => new
    {
        threadPost_id = t.ThreadPost_Id,
        user_id = t.User_Id,
        title = t.Title,
        text = t.Text,
        uRL = t.URL,
        postDateTime = t.PostDateTime,
        vote = t.Vote,
    });
});
app.MapGet("api/threadPost/{id}", (DataService service, int id) =>
{
    var threadPost = service.GetThreadPost(id);
    return threadPost != null ? Results.Ok(threadPost) : Results.BadRequest("id out of range check /api/threadPosts");
});

app.MapPost("api/threadPost", (DataService service,ThreadPost threadPost) =>
{
    service.PostThreadPost(threadPost);
});


app.MapPut("api/threadPost/vote",(DataService service,ThreadPostVote threadPostVote) =>{
    
    service.PutThreadPostVote(threadPostVote.ThreadPost_Id,threadPostVote.Vote);
});

app.MapGet("/api/comments", (DataService service) =>
{
    return service.GetComments().Select(c => new
    {
        comment_id = c.Comment_Id,
        user_id = c.User_Id,
        threadPost_id = c.ThreadPost_Id,
        text = c.Text,
        uRL = c.URL,
        postDateTime = c.PostDateTime,
        vote = c.Vote
    });
});
app.MapGet("api/comment/{id}", (DataService service, int id) =>
{
    var comment = service.GetComment(id);
    return comment != null ? Results.Ok(comment) : Results.BadRequest("id out of range check /api/comments");
});

app.MapPost("api/comment", (DataService service,Comment comment) =>
{
    service.PostComment(comment);
});

app.MapPut("/api/comment/vote", (DataService service, CommentVote commentVote) =>
{
    Console.WriteLine("Hejsa");
    service.PutCommentVote(commentVote.Comment_Id, commentVote.Vote);
});



app.Run();
//await builder.Build().RunAsync();
record CommentNew(int User_Id, int ThreadPost_Id,string Text, string URL, DateTime PostDateTime);
record CommentVote(int Comment_Id,int Vote);
record ThreadPostVote(int ThreadPost_Id,int Vote);
