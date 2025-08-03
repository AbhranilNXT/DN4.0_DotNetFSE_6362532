import './App.css';
import officeImage from './office.jpeg'; 

function App() {
  const officeList = [
    { Name: "DBS", Rent: 50000, Address: "Chennai" },
    { Name: "WeWork", Rent: 75000, Address: "Bangalore" },
    { Name: "Regus", Rent: 45000, Address: "Mumbai" }
  ];

  return (
    <div className="App">
      <h1>Office Space, at Affordable Range</h1>
      <img src={officeImage} width="25%" height="25%" alt="Office Space"/>
      
      <hr />

      {officeList.map((office) => (
        <div key={office.Name}>
          <h2>Name: {office.Name}</h2>
          <h3 className={office.Rent <= 60000 ? 'textRed' : 'textGreen'}>
            Rent: Rs. {office.Rent}
          </h3>
          
          <h3>Address: {office.Address}</h3>
          <hr />
        </div>
      ))}
    </div>
  );
}

export default App;