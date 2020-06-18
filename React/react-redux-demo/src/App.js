import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Provider } from 'react-redux'
import CakeContainer from './Components/CakeContainer';
import store from './redux/store'
import HooksCakeContainer from './Components/HooksCakeContainer';
import IceCreamContainer from './Components/IceCreamContainer';

function App() {
  return (
    <Provider store={store}>
    <div className="App">
      <HooksCakeContainer/>
      <IceCreamContainer/>
      {/* <CakeContainer/> */}
    </div>
    </Provider>
  );
}

export default App;
