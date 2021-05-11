using EFandLINQProject.Models;
using System;
using System.Linq;

namespace EFandLINQProject
{
    class Program
    {
        PostRepo postRepo;
        CommentRepo commentRepo;
        TweetContext context;
        public Program()
        {
            context = new TweetContext();
            commentRepo = new CommentRepo(context);
            postRepo = new PostRepo(context);
        }
        void PrintPostWithComments()
        {
            var postWiseComment = context.Comments.ToList().GroupBy(c => c.PostId);
            foreach (var postComment in postWiseComment)
            {
                int id = postComment.Key;
                Post post = postRepo.Get(id);
                PrintPost(post);
                Console.WriteLine("Comment for his post");
                foreach (var comment in postComment)
                {
                    PrintComment(comment);
                }
                Console.WriteLine("---------------------------");
            }
        }
        void PrintComment(Comment comment)
        {
            Console.WriteLine("Comment id "+comment.Id);
            Console.WriteLine(comment.CommneText);
        }
        void AddPost()
        {
            Console.WriteLine("Please enter the Post Category");
            string category = Console.ReadLine();
            Console.WriteLine("Please enter the Post text");
            string text = Console.ReadLine();
            Post post = new Post();
            post.Category = category;
            post.PostText = text;
            if(postRepo.Add(post))
                Console.WriteLine("The post is posted");
            else
                Console.WriteLine("Could not post");
        }
        void updatePostText()
        {
            int id = 0;
            Console.WriteLine("Pleas eneter the id for which you update the post Text");
            id = Convert.ToInt32(Console.ReadLine());
            Post post = postRepo.Get(id);
            if(post != null)
            {
                Console.WriteLine("Please enter the text to add with post text");
                string updated_text = Console.ReadLine();
                post.PostText = post.PostText+" "+updated_text;
                Console.WriteLine("Updated text");
            }
        }
        
        void PrintPosts()
        {
            var posts = postRepo.GetAll();
            if(posts != null)
                foreach (var item in posts.ToList())
                {
                    PrintPost(item);
                }
        }
        void PrintPost(Post post)
        {
            Console.WriteLine("Post_ID: " + post.Id);
            Console.WriteLine("Post_category: " + post.Category);
            Console.WriteLine("Post: " + post.PostText);
        }
        void AddCommentToPost()
        {
            PrintPosts();
            int id = 0;
            Console.WriteLine("Pleas eneter the id for which you enter the comment");
            id = Convert.ToInt32(Console.ReadLine());
            Post post = postRepo.Get(id);
            if (post != null)
            {
                PrintPost(post);
                Comment comment = TakeComment(id);
                if(commentRepo.Add(comment))
                    Console.WriteLine("comment updated");
            }
        }
        private Comment TakeComment(int pid) 
        {
            Comment comment = new Comment();
            comment.PostId = pid;
            Console.WriteLine("Please enter the comment");
            comment.CommneText = Console.ReadLine();
            return comment;
        }
        void userinterface()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add a post");
                Console.WriteLine("2.Add a comment to post");
                Console.WriteLine("3.print all posts");
                Console.WriteLine("4.print comments of that post");
                Console.WriteLine("5.Update the Post text");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter the choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddPost();
                        break;
                    case 2:
                        AddCommentToPost();
                        break;
                    case 3:
                        PrintPosts();
                        break;
                    case 4:
                        PrintPostWithComments();
                        break;
                    case 5:
                        updatePostText();
                        break;
                    case 6:
                        Console.WriteLine("Exitting");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 6);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.userinterface();
        }
    }
}
