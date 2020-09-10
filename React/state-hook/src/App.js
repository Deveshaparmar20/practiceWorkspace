import React,{useReducer, useContext} from 'react';
import './App.css';
//import CounterOne from './components/UseReducer/CounterOne';
import CounterOne from './components/CustomHook/CounterOne'
import CounterTwo from './components/CustomHook/CounterTwo'
//import CounterTwo from './components/UseReducer/CounterTwo';
import CounterThree from './components/UseReducer/CounterThree';
import ComponentA from './components/UseReducer/ComponentA';
import ComponentB from './components/UseReducer/ComponentB';
import ComponentC from './components/UseReducer/ComponentC';
import ParentComponent from './components/UseCallback/ParentComponent';
import Counter from './components/UseMemo/Counter';
import HookTimer from './components/UseRef/HookTimer';
import DocTitleOne from './components/CustomHook/DocTitleOne';
import DocTitleTwo from './components/CustomHook/DocTitleTwo';
import UserForm from './components/CustomHook/UserForm';

export const CountContext = React.createContext()

const initialState = 0;
const reducer = (state, action) => {
    switch (action) {
        case 'increment':
            return state + 1;
        case 'decrement':
            return state - 1;
        case 'reset':
            return initialState;
        default:
            return state
    }
}
//export const UserContext = React.createContext();
//export const ChannelContext = React.createContext();
function App() {
  const [count, dispatch] = useReducer(reducer,initialState)
  return (
    //<CountContext.Provider value={{countState:count, countDispatch:dispatch}}>
    <div className="App">
      <UserForm />
      {/* <CounterOne />
      <CounterTwo /> */}
      {/* <DocTitleOne />
      <DocTitleTwo /> */}
      {/* <HookTimer /> */}
      {/* <Counter /> */}
      {/* <ParentComponent /> */}
      {/* Count - {count}
      <ComponentA />
      <ComponentB />
      <ComponentC /> */}
      {/* <UserContext.Provider value="Devesha">
        <ChannelContext.Provider value="React Learning">
          <ComponentC />
        </ChannelContext.Provider>
      </UserContext.Provider> */}
    </div>
    //</CountContext.Provider>
  );
}

export default App;
