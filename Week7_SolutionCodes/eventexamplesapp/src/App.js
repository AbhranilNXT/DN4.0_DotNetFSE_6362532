import './App.css';
import Counter from './Counter';
import Welcome from './Welcome';
import SyntheticEvent from './SyntheticEvent';
import CurrencyConvertor from './CurrencyConvertor';

function App() {
  return (
    <div className="App">
      <h1>React Event Examples</h1>
      <hr />
      <Counter />
      <hr />
      <Welcome />
      <hr />
      <SyntheticEvent />
      <hr />
      <CurrencyConvertor />
    </div>
  );
}

export default App;