import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import Greet from './components/Greet'
import Welcome from './components/Welcome'
import Hello from './components/Hello'
import Message from './components/Message'
import Counter from './components/Counter';
import FunctionClick from './components/FunctionClick';
import ClassClick from './components/ClassClick';
import EventBind from './components/EventBind';
import ParentComponent from './components/ParentComponent';
import UserGreeting from './components/UserGreeting';
import NameList from './components/NameList';
import Stylesheet from './components/Stylesheet';
import Inline from './components/Inline';
import './appStyles.css';
import style from './appStyles.module.css';
class App extends Component {
  render() {
    return (
      <div className="App">
        <h1 className='error'>Error</h1>
        <h1 className={style.success}>Success</h1>
        {/* <Inline></Inline> */}
      {/* <Stylesheet primary={true}/> */}
        {/* <NameList></NameList> */}
        {/* <UserGreeting></UserGreeting> */}
        {/* <ParentComponent></ParentComponent> */}
        {/* <EventBind/> */}
        {/* <Greet name="Bruce" heroName="Batman"></Greet> */}
        {/* <Welcome name="Clark" heroName="Superman"></Welcome>*/}
        {/* <Counter/>
        <FunctionClick></FunctionClick>
        <ClassClick/> */}
      </div>
    )
  };
}

export default App;