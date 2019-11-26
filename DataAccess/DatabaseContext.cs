﻿using Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class DatabaseContext
    {
        private readonly IMongoDatabase _database = null;

        public DatabaseContext()
        {

            var client = new MongoClient("mongodb://omarfut:81Osuzov@35.246.173.246:27017/admin");
            if (client != null)
                _database = client.GetDatabase("maindb");
        }

        public IMongoCollection<Post> Posts
        {
            get
            {
                return _database.GetCollection<Post>("posts");
            }
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("users");

        public IMongoCollection<Comment> Comments => _database.GetCollection<Comment>("comments");

        public IMongoCollection<Answer> Answers => _database.GetCollection<Answer>("answers");

        public IMongoCollection<CommentPreview> LatestComments => _database.GetCollection<CommentPreview>("latestComments");
    }
}