import React, { Component } from 'react';
import './assets/css/Login.css'


class App extends Component {
  constructor() {
    super();
    this.state = {
      email: "",
      senha: ""
    }
  }

  atualizaestado(event) {
    this.setState({ [event.target.name]: event.target.value })
  }

  logando() {
    if (this.state.email === "Gandolf" && this.state.senha === "132") {
      this.props.history.push("/pizzaria")
    } else {
      alert("Email ou senha incorretos")
    }
  }

  render() {
    return (
      <section className="Main">

        <div className="Main-Content">
          <div className="container-formulario">
            <div className="main-div__content">
              <div className="row">
                <div className="item titulo-formulario" id="item__title">
                  <h2 className="text__login" id="item__description">
                    Login
                  </h2>
                </div>
                <form onSubmit={this.logando.bind(this)}>
                  <div className="item item-formulario">
                    <label className="text__login">Email:</label>
                    <input type="text" value={this.state.email} onChange={this.atualizaestado.bind(this)} name="email" />
                  </div>

                  <div className="item item-formulario">
                    <label className="text__login">Senha:</label>
                    <input type="password" value={this.state.senha} onChange={this.atualizaestado.bind(this)} name="senha" />
                  </div>

                  <div className="item item-formulario-btn">
                    <button className="btn btn__login" type="submit">Entrar</button>
                  </div>

                </form>

              </div>
            </div>
          </div>
        </div>
      </section>
    )
  }
}


export default App;
