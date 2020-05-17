import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import './appStyles.css';
import RefsDemo from './components/RefsDemo';
import FocusInput from './components/FocusInput';
import FRParentInput from './components/FRParentInput';
import PortalDemo from './components/PortalDemo';
import Hero from './components/Hero';
import ErrorBoundary from './components/ErrorBoundary';
import ClickCounter from './components/ClickCounter';
import HoverCounter from './components/HoverCounter';

class App extends Component {
  render() {
    return (
      <div className="App"> 
      <HoverCounter/>
      <ClickCounter name='devesha'/>
      {/* <ErrorBoundary>
      <Hero heroName="Batman"/>
      <Hero heroName="Superman"/>
      <Hero heroName="Joker"/> 
      </ErrorBoundary> */}
      {/* <PortalDemo/>   */}
      {/* <FRParentInput/> */}
      {/* <FocusInput/> */}
      </div>
    )
  };
}

export default App;
