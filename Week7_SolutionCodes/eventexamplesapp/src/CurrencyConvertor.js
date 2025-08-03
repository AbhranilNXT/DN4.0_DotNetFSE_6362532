import React, { useState } from 'react';

function CurrencyConvertor() {
  const [rupees, setRupees] = useState(0);
  const [euros, setEuros] = useState(0);
  const conversionRate = 90.50;

  const handleRupeesChange = (e) => {
    setRupees(e.target.value);
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const euroValue = rupees / conversionRate;
    setEuros(euroValue.toFixed(2));
    alert('Conversion successful!');
  };

  return (
    <div>
      <h2>Currency Convertor</h2>
      <form onSubmit={handleSubmit}>
        <label>
          Indian Rupees (INR):
          <input type="number" value={rupees} onChange={handleRupeesChange} />
        </label>
        <button type="submit">Convert</button>
      </form>
      <h3>Euros (EUR): €{euros}</h3>
    </div>
  );
}

export default CurrencyConvertor;