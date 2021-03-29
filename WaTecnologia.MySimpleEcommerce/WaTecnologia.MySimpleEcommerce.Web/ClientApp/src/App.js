import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Customers } from './components/Pages/Customers/index';
import { Products } from './components/Pages/Products/index';
import { Orders } from './components/Pages/Orders/index';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route exact path='/' component={Products} />
            <Route path='/customers' component={Customers} />
            <Route path='/orders' component={Orders} />
      </Layout>
    );
  }
}
