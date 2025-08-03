import React from 'react';

function BlogDetails(props) {
  const showBlogs = true;

  return (
    <div className="column">
      <h1>Blog Details</h1>
      {showBlogs &&
        props.blogs.map((blog) => (
          <div key={blog.id}>
            <h2>{blog.title}</h2>
            <p>{blog.author}</p>
            <p>{blog.content}</p>
          </div>
        ))}
    </div>
  );
}

export default BlogDetails;