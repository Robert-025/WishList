import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect } from 'react-router-dom';

import './index.css';

import App from './pages/home/App.js';
import Desejos from './pages/desejos/desejos.js';
import NotFound from './pages/notFound/notFound.js'

import reportWebVitals from './reportWebVitals';

const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={App}/>  {/* Home */}
        <Route path="/desejo" component={Desejos}/>  {/* listagemCadastro */}
        <Route path="/notFound" component={NotFound}/>  {/* Not Found */}
        <Redirect to="/notFound"/>  {/* Redireciona para notFOund caso não encontre nenhuma rota */}
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(routing, document.getElementById('root'));

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
