using Microsoft.EntityFrameworkCore;
using MiniProjectRaddit.Model;
using MiniProjectRadditDatabase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectRadditDatabase.Service
{
    public class DataService
    {
        private DbALLDATAContext db;
        public DataService(DbALLDATAContext db)
        {
            this.db = db;
        }

        public void SeedData()
        {
            
            User user = db.Users.FirstOrDefault()!;
            if (user == null)
            {
                db.Add(new User("Brian"));
                db.Add(new User("John"));
                db.Add(new User("Kennth"));
                db.Add(new User("Jacob"));
                db.Add(new User("Jonathan"));
            }
            #region ThreadPosts
            ThreadPost threadPost = db.ThreadPosts.FirstOrDefault()!;
            if (threadPost == null)
            {
                ThreadPost threadPosting1 = new ThreadPost(1, "Gurt", new DateTime(2009, 01, 01), "lave gurt mad?", string.Empty);
                db.ThreadPosts.Add(threadPosting1);

                ThreadPost threadPosting2 = new ThreadPost(1, "Hulle", new DateTime(2010, 01, 01), "En hule?", string.Empty);
                db.ThreadPosts.Add(threadPosting2);

                ThreadPost threadPosting3 = new ThreadPost(1, "Fisk køb", new DateTime(2019, 01, 01), "Hvor er fiskerne?", string.Empty);
                db.ThreadPosts.Add(threadPosting3);

                ThreadPost threadPosting4 = new ThreadPost(1, "Bord bygning", new DateTime(2015, 01, 01), "Skade af bord", string.Empty);
                db.ThreadPosts.Add(threadPosting4);

                ThreadPost threadPosting5 = new ThreadPost(1, "Computer problem", new DateTime(2025, 01, 01), "Kastet den ud af vinduet?", string.Empty);
                db.ThreadPosts.Add(threadPosting5);

                ThreadPost threadPosting6 = new ThreadPost(1, "Boglæsning", new DateTime(2029, 01, 01), "Hvor er min bog?", string.Empty);
                db.ThreadPosts.Add(threadPosting6);

                ThreadPost threadPosting7 = new ThreadPost(1, "Aliens", new DateTime(2015, 01, 01), "Vi bliver snart invaderet af Aliens! År 2150", string.Empty);
                db.ThreadPosts.Add(threadPosting7);

                ThreadPost threadPosting8 = new ThreadPost(1, "Menneskerne i det hvide hus", new DateTime(2020, 05, 15), "De burde være gadefejre", string.Empty);
                db.ThreadPosts.Add(threadPosting8);

                ThreadPost threadPosting9 = new ThreadPost(1, "Jorden går under", new DateTime(2017, 04, 24), "Det sker 2012 på min fødselsdag :(", string.Empty);
                db.ThreadPosts.Add(threadPosting9);

                ThreadPost threadPosting10 = new ThreadPost(1, "Strømpers kemi?", new DateTime(2021, 07, 19), "Fatter ikke, hvorfor folk ikke tror de er lavet af bordskåner", string.Empty);
                db.ThreadPosts.Add(threadPosting10);


                ThreadPost threadPosting11 = new ThreadPost(2, "Chips", new DateTime(2012, 04, 01), "De spise når man sidder på et jakkesæt", string.Empty);
                db.ThreadPosts.Add(threadPosting11);

                ThreadPost threadPosting12 = new ThreadPost(2, "Fun fact", new DateTime(2013, 03, 01), "Jeg er medium sej", string.Empty);
                db.ThreadPosts.Add(threadPosting12);

                ThreadPost threadPosting13 = new ThreadPost(2, "Forlystelser", new DateTime(2014, 01, 01), "De snyder man skal betale penge for at prøve!", string.Empty);
                db.ThreadPosts.Add(threadPosting13);

                ThreadPost threadPosting14 = new ThreadPost(2, "Biler reparation", new DateTime(2015, 01, 01), "Kender i det når man skal lave sin bil på en fredagsbar?", string.Empty);
                db.ThreadPosts.Add(threadPosting14);

                ThreadPost threadPosting15 = new ThreadPost(2, "Tryk på det link her", new DateTime(2022, 02, 01), string.Empty, "https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                db.ThreadPosts.Add(threadPosting15);

                ThreadPost threadPosting16 = new ThreadPost(2, "Få en virus!!", new DateTime(2039, 01, 01), "", "https://faktalink.dk/virus");
                db.ThreadPosts.Add(threadPosting16);

                ThreadPost threadPosting17 = new ThreadPost(2, "Hvad laver jeg?", new DateTime(2014, 09, 01), "Noget du ikke forstå xD xD xD xD", string.Empty);
                db.ThreadPosts.Add(threadPosting17);

                ThreadPost threadPosting18 = new ThreadPost(2, "Jeg gider ikke give et link, men sig hej!", new DateTime(2020, 05, 15), ":D den lille rødbede!", string.Empty);
                db.ThreadPosts.Add(threadPosting18);

                ThreadPost threadPosting19 = new ThreadPost(2, "Chokolade snak", new DateTime(2017, 04, 24), "snak om chokolade her!", string.Empty);
                db.ThreadPosts.Add(threadPosting19);

                ThreadPost threadPosting20 = new ThreadPost(2, "Sange?", new DateTime(2021, 07, 19), "Hvad fanden laver jeg :O", string.Empty);
                db.ThreadPosts.Add(threadPosting20);



                ThreadPost threadPosting21 = new ThreadPost(3, "Chips", new DateTime(2012, 04, 01), "De spise når man sidder på et jakkesæt", string.Empty);
                db.ThreadPosts.Add(threadPosting21);

                ThreadPost threadPosting22 = new ThreadPost(3, "Fun fact", new DateTime(2013, 03, 01), "Jeg er medium sej", string.Empty);
                db.ThreadPosts.Add(threadPosting12);

                ThreadPost threadPosting23 = new ThreadPost(3, "Forlystelser", new DateTime(2014, 01, 01), "De snyder man skal betale penge for at prøve!", string.Empty);
                db.ThreadPosts.Add(threadPosting23);

                ThreadPost threadPosting24 = new ThreadPost(3, "Biler reparation", new DateTime(2015, 01, 01), "Kender i det når man skal lave sin bil på en fredagsbar?", string.Empty);
                db.ThreadPosts.Add(threadPosting24);

                ThreadPost threadPosting25 = new ThreadPost(3, "Tryk på det link her", new DateTime(2022, 02, 01), string.Empty, "https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                db.ThreadPosts.Add(threadPosting25);

                ThreadPost threadPosting26 = new ThreadPost(3, "Få en virus!!", new DateTime(2039, 01, 01), "", "https://faktalink.dk/virus");
                db.ThreadPosts.Add(threadPosting26);

                ThreadPost threadPosting27 = new ThreadPost(3, "Hvad laver jeg?", new DateTime(2014, 09, 01), "Noget du ikke forstå xD xD xD xD", string.Empty);
                db.ThreadPosts.Add(threadPosting27);

                ThreadPost threadPosting28 = new ThreadPost(3, "Jeg gider ikke give et link, men sig hej!", new DateTime(2020, 05, 15), ":D den lille rødbede!", string.Empty);
                db.ThreadPosts.Add(threadPosting28);

                ThreadPost threadPosting29 = new ThreadPost(3, "Chokolade snak", new DateTime(2017, 04, 24), "snak om chokolade her!", string.Empty);
                db.ThreadPosts.Add(threadPosting29);

                ThreadPost threadPosting30 = new ThreadPost(3, "Sange?", new DateTime(2021, 07, 19), "Hvad fanden laver jeg :O", string.Empty);
                db.ThreadPosts.Add(threadPosting30);





                ThreadPost threadPosting31 = new ThreadPost(4, "Chips", new DateTime(2012, 04, 01), "De spise når man sidder på et jakkesæt", string.Empty);
                db.ThreadPosts.Add(threadPosting31);

                ThreadPost threadPosting32 = new ThreadPost(4, "Fun fact", new DateTime(2013, 03, 01), "Jeg er medium sej", string.Empty);
                db.ThreadPosts.Add(threadPosting32);

                ThreadPost threadPosting33 = new ThreadPost(4, "Forlystelser", new DateTime(2014, 01, 01), "De snyder man skal betale penge for at prøve!", string.Empty);
                db.ThreadPosts.Add(threadPosting33);

                ThreadPost threadPosting34 = new ThreadPost(4, "Biler reparation", new DateTime(2015, 01, 01), "Kender i det når man skal lave sin bil på en fredagsbar?", string.Empty);
                db.ThreadPosts.Add(threadPosting34);

                ThreadPost threadPosting35 = new ThreadPost(4, "Tryk på det link her", new DateTime(2022, 02, 01), string.Empty, "https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                db.ThreadPosts.Add(threadPosting35);

                ThreadPost threadPosting36 = new ThreadPost(4, "Få en virus!!", new DateTime(2039, 01, 01), "", "https://faktalink.dk/virus");
                db.ThreadPosts.Add(threadPosting36);

                ThreadPost threadPosting37 = new ThreadPost(4, "Hvad laver jeg?", new DateTime(2014, 09, 01), "Noget du ikke forstå xD xD xD xD", string.Empty);
                db.ThreadPosts.Add(threadPosting37);

                ThreadPost threadPosting38 = new ThreadPost(4, "Jeg gider ikke give et link, men sig hej!", new DateTime(2020, 05, 15), ":D den lille rødbede!", string.Empty);
                db.ThreadPosts.Add(threadPosting38);

                ThreadPost threadPosting39 = new ThreadPost(4, "Chokolade snak", new DateTime(2017, 04, 24), "snak om chokolade her!", string.Empty);
                db.ThreadPosts.Add(threadPosting39);

                ThreadPost threadPosting40 = new ThreadPost(4, "Sange?", new DateTime(2021, 07, 19), "Hvad fanden laver jeg :O", string.Empty);
                db.ThreadPosts.Add(threadPosting40);



                ThreadPost threadPosting41 = new ThreadPost(5, "Chips", new DateTime(2012, 04, 01), "De spise når man sidder på et jakkesæt", string.Empty);
                db.ThreadPosts.Add(threadPosting41);

                ThreadPost threadPosting42 = new ThreadPost(5, "Fun fact", new DateTime(2013, 03, 01), "Jeg er medium sej", string.Empty);
                db.ThreadPosts.Add(threadPosting42);

                ThreadPost threadPosting43 = new ThreadPost(5, "Forlystelser", new DateTime(2014, 01, 01), "De snyder man skal betale penge for at prøve!", string.Empty);
                db.ThreadPosts.Add(threadPosting43);

                ThreadPost threadPosting44 = new ThreadPost(5, "Biler reparation", new DateTime(2015, 01, 01), "Kender i det når man skal lave sin bil på en fredagsbar?", string.Empty);
                db.ThreadPosts.Add(threadPosting44);

                ThreadPost threadPosting45 = new ThreadPost(5, "Tryk på det link her", new DateTime(2022, 02, 01), string.Empty, "https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                db.ThreadPosts.Add(threadPosting45);

                ThreadPost threadPosting46 = new ThreadPost(5, "Få en virus!!", new DateTime(2039, 01, 01), "", "https://faktalink.dk/virus");
                db.ThreadPosts.Add(threadPosting46);

                ThreadPost threadPosting47 = new ThreadPost(5, "Hvad laver jeg?", new DateTime(2014, 09, 01), "Noget du ikke forstå xD xD xD xD", string.Empty);
                db.ThreadPosts.Add(threadPosting47);

                ThreadPost threadPosting48 = new ThreadPost(5, "Jeg gider ikke give et link, men sig hej!", new DateTime(2020, 05, 15), ":D den lille rødbede!", string.Empty);
                db.ThreadPosts.Add(threadPosting48);

                ThreadPost threadPosting49 = new ThreadPost(5, "Chokolade snak", new DateTime(2017, 04, 24), "snak om chokolade her!", string.Empty);
                db.ThreadPosts.Add(threadPosting49);

                ThreadPost threadPosting50 = new ThreadPost(5, "Sange?", new DateTime(2021, 07, 19), "Hvad fanden laver jeg :O", string.Empty);
                db.ThreadPosts.Add(threadPosting50);

                ThreadPost threadPosting51 = new ThreadPost(5, "Sange?", new DateTime(2021, 07, 19), "Hvad fanden laver jeg :O", string.Empty);
                db.ThreadPosts.Add(threadPosting51);

            }
            #endregion ThreadPosts





            Comment comment = db.Comments.FirstOrDefault()!;
            if (comment == null)
            {
                Comment comment1 = new Comment(1, 1, "Det er sjovt xD", string.Empty, new DateTime(2010, 04, 02));
                db.Comments.Add(comment1);
                Comment comment2 = new Comment(1, 1, "Hahaha", string.Empty, new DateTime(2010, 01, 02));
                db.Comments.Add(comment2);

                Comment comment3 = new Comment(3, 2, "Lul wut !??", string.Empty, new DateTime(2010, 04, 02));
                db.Comments.Add(comment3);
            }


            db.SaveChanges();
        }



        public List<User> GetUsers()
        {
          return db.Users.ToList();
        }

        public User GetUser(int id)
        {
            return db.Users.FirstOrDefault(u => u.User_Id == id);
        }

        public List<ThreadPost> GetThreadPosts()
        {
            return db.ThreadPosts.ToList();
        }

        public ThreadPost GetThreadPost(int id)
        {
            return db.ThreadPosts.FirstOrDefault(t => t.ThreadPost_Id == id);
        }

        public string PutThreadPostVote(int threadPostId, int vote)
        {
            Console.WriteLine("Jeg er inde votes: " + vote);
            var threadPost = db.ThreadPosts.FirstOrDefault(t => t.ThreadPost_Id == threadPostId);
            threadPost.Vote = vote;
            db.SaveChanges();
            return "Voted";
        }

        public string PostThreadPost(ThreadPost threadPost)
        {
            db.ThreadPosts.Add(threadPost);
            db.SaveChanges();
            return "ThreadPost posted";
        }

        public List<Comment> GetComments()
        {
            return db.Comments.ToList();
        }

        public Comment GetComment(int id)
        {
            return db.Comments.FirstOrDefault(c => c.Comment_Id == id);
        }
        

        public string PutCommentVote(int commentId, int vote)
        {
            Console.WriteLine("Jeg er inde votes: " + vote);
            var comment = db.Comments.FirstOrDefault(c => c.Comment_Id == commentId);
            comment.Vote = vote;
            db.SaveChanges();
            return "Voted";
        }

        public string PostComment(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return "Comment posted";
        }
    }
}
