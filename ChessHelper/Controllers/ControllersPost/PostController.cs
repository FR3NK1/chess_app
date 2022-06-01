﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using ChessHelper.Infrastructure.Repository.RepositoryPost;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersPost
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostRepository _PostRepository;
        public PostController(IPostRepository PostRepository)
        {
            _PostRepository = PostRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllVideoLessons()
        {
            return new OkObjectResult(_PostRepository.GetAllPost());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPost(int id)
        {
            return new OkObjectResult(_PostRepository.GetPost(id));
        }
    }
}
