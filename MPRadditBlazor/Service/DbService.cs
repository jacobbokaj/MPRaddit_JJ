using MiniProjectRaddit.Model;
using System.Net.Http.Json;
using TodoListBlazor.Shared;
using static System.Net.WebRequestMethods;

namespace MiniProjectRaddit.Service
{
    public class DbService
    {
        private readonly HttpClient http;
        private readonly IConfiguration configuration;
        private readonly string baseAPI = "";


        public DbService(HttpClient http, IConfiguration configuration)
        {
            Console.WriteLine(http);
            this.http = http;
            this.configuration = configuration;
            this.baseAPI = configuration["base_api"];
            Console.WriteLine(baseAPI);
        }




        public async Task<List<User>> GetUsers()
        {
            string url = $"{baseAPI}/users";
            User[] users = await http.GetFromJsonAsync<User[]>(url);
            return users.ToList();
        }

        public async Task<List<ThreadPost>> GetThreadPosts()
        {
            string url = $"{baseAPI}/threadPosts";
            Console.WriteLine(url);
            ThreadPost[] posts = await http.GetFromJsonAsync<ThreadPost[]>(url);
            return posts.ToList();
        }
        public async Task<List<Comment>> GetComments()
        {
            string url = $"{baseAPI}/comments";
            Comment[] comments = await http.GetFromJsonAsync<Comment[]>(url);
            return comments.ToList();
        }



        public async Task PutCommentVote(int comment_id, int vote)
        {
            string url = $"{baseAPI}/comment/vote";
            Console.WriteLine(url);
            Comment comment = MainLayoutAndData.Comments.FirstOrDefault(c => c.Comment_Id == comment_id);
            comment.Vote += vote;
            var posts = await http.PutAsJsonAsync(url,comment);
        }



        public async Task PostComment(Comment comment)
        {
            string url = $"{baseAPI}/comment";
            var res = await http.PostAsJsonAsync(url, comment);
        }


        public async Task PutThreadPostVote(int threadPost_id, int vote)
        {
            string url = $"{baseAPI}/thread/vote";
            Console.WriteLine(url);
            ThreadPost threadPost = MainLayoutAndData.ThreadPosts.FirstOrDefault(t => t.ThreadPost_Id == threadPost_id);
            threadPost.Vote += vote;
            var posts = await http.PutAsJsonAsync(url, threadPost);
        }



        public async Task PostThreadPost(ThreadPost threadPost)
        {
            string url = $"{baseAPI}/threadPost";
            var res = await http.PostAsJsonAsync(url, threadPost);
        }
    }
}
