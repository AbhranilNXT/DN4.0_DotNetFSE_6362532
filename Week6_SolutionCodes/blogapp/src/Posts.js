import React, { Component } from 'react';
import Post from './Post';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  loadPosts = () => {
    fetch("https://jsonplaceholder.typicode.com/posts")
      .then(response => response.json())
      .then(data => {
        const postList = data.map(post => new Post(post.userId, post.id, post.title, post.body));
        this.setState({ posts: postList });
      })
      .catch(error => {
        console.error("Error fetching posts:", error);
        this.setState({ hasError: true });
      });
  };

  componentDidMount() {
    this.loadPosts();
  }

  render() {
  if (this.state.hasError) {
    return <h2>Something went wrong. Try again later.</h2>;
  }

  return (
    <div>
      <h1>Blog Posts</h1>
      {this.state.posts.map(post => (
        <div key={post.id} style={{ marginBottom: '20px', borderBottom: '1px solid #ccc', paddingBottom: '10px' }}>
          <p><strong>Post ID:</strong> {post.id}</p>
          <p><strong>User ID:</strong> {post.userId}</p>
          <h3>{post.title}</h3>
          <p>{post.body}</p>
        </div>
      ))}
    </div>
  );
}

  componentDidCatch(error, info) {
    alert("An error occurred while rendering posts.");
    console.error("Error caught:", error, info);
    this.setState({ hasError: true });
  }
}

export default Posts;
