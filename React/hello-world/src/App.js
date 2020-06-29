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
import ClickCounterTwo from './components/ClickCounterTwo';
import HoverCounterTwo from './components/HoverCounterTwo';
import User from './components/User';
import CounterA from './components/CounterA';
import ComponentC from './components/ComponentC';
import Greet from './components/Greet'
import { UserProvider } from './components/UserContext';

class App extends Component {
  render() {
    return (
      <div className="App">
        <Greet name="dev" heroName="parmar" />
        {/* <UserProvider value="Devesha">
        <ComponentC/>
        </UserProvider> */}
        {/* <CounterA>
          {(count, incrementCount) =>
          (<ClickCounterTwo count={count} incrementCount={incrementCount} />)}
        </CounterA>

        <CounterA>
          {(count, incrementCount) =>
          (<HoverCounterTwo count={count} incrementCount={incrementCount} />)}
        </CounterA> */}

        {/* <HoverCounter/>
      <ClickCounter name='devesha'/> */}
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
