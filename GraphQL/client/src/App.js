import React from 'react';
import ApolloClient from 'apollo-boost'
import { ApolloProvider } from 'react-apollo'
import BookList from './components/BookList';
import AddBook from './components/AddBook';

// apollo client setup
const client = new ApolloClient({
  uri: 'http://localhost:4000/graphql'
})

function App() {
  return (
    <ApolloProvider client={client}>
      <div id="main">
        <h1>Reading book list</h1>
        <BookList />
        <AddBook />
      </div>
    </ApolloProvider>
  );
}
console.log(3 > 2 > 1);

console.log(1 < 2 < 3);

export default App;
