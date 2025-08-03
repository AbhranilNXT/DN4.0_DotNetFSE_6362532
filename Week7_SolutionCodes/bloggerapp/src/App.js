// src/App.js
import './App.css';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';
import { books, blogs, courses } from './data.js';

function App() {
  return (
    <div className="App">
      <div className="container">
        <CourseDetails courses={courses} />
        <BookDetails books={books} />
        <BlogDetails blogs={blogs} />
      </div>
    </div>
  );
}

export default App;