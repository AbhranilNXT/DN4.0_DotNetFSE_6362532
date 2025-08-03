import React from 'react';

function CourseDetails(props) {
  const coursesAvailable = props.courses.length > 0;

  return (
    <div className="column">
      <h1>Course Details</h1>
      {coursesAvailable ? (
        props.courses.map((course) => (
          <div key={course.id}>
            <h2>{course.name}</h2>
            <p>{course.date}</p>
          </div>
        ))
      ) : (
        <p>No courses available.</p>
      )}
    </div>
  );
}

export default CourseDetails;