import React, { Component } from 'react'
import apiService from '../services/apiServices'
import '../assets/css/Pizzaria.css'

class Pizzaria extends Component {
    constructor() {
        super();
        this.state = {
            nome: "",
            endereco: "",
            telefone: "",
            opcaoVegana: true,
            idcategoria: "",
            lista: [],
            categorias: []
        }
    }

    atualizaEstado(event) {
        this.setState({ [event.target.name]: event.target.value })
    }

    atualizaEstadoIdCategoria(event) {
        this.setState({ idcategoria: event.target.value })
    }

    componentDidMount() {
        apiService
            .call("Pizzarias")
            .getAll()
            .then(data => {
                this.setState({ lista: data.data });
            })

        apiService
            .call("Categorias")
            .getAll()
            .then(data => {
                this.setState({ categorias: data.data });
            })
    }

    cadastroPizzarias() {
        apiService

            .call("pizzarias")
            .create({
                nome: this.state.nome,
                endereco: this.state.endereco,
                telefone: this.state.telefone,
                opcao_vegana: this.state.opcaoVegana,
                idcategoria: this.state.idcategoria
            })
            .then(data => {
                if (data.status === 200) {
                    console.log(data);
                }
            })
            .catch(erro => { console.log(erro) })
    }

    render() {
        return (
            <main className="main__pizzarias">
                <div className="main-div__pizzarias">
                    <div className="main-div__sections">

                        <section className="cadastro_pizzaria">
                            <div className="container">
                                <h2>Cadastro de Pizzarias</h2>
                                <form  onSubmit={this.cadastroPizzarias.bind(this)} className="section__form">
                                    <div>
                                        <label>Nome: </label>
                                        <input value={this.state.nome} onChange={this.atualizaEstado.bind(this)} name="nome" type="text" />
                                    </div>

                                    <div>
                                        <label>Enderço: </label>
                                        <input value={this.state.endereco} onChange={this.atualizaEstado.bind(this)} name="endereco" type="adress" />
                                    </div>

                                    <div>
                                        <label>Telefone: </label>
                                        <input value={this.state.telefone} onChange={this.atualizaEstado.bind(this)} name="telefone" type="tell" />
                                    </div>

                                    <div>
                                        <label>Possui opção vegana: </label>
                                        <input value={this.state.opcaoVegana} defaultChecked={this.state.opcaoVegana} onChange={this.atualizaEstado.bind(this)} name="opcaoVegana" type="checkbox" />
                                    </div>

                                    <div>
                                        <label>Selecione a categoria: </label>
                                        <select value={this.state.idcategoria} onChange={this.atualizaEstadoIdCategoria.bind(this)} >
                                            <option>Selecione</option>
                                            {this.state.categorias.map((element) => {
                                                return <option key={element.id} value={element.id}>
                                                    {element.nome + " = " + element.valor}
                                                </option>
                                            })}
                                        </select>
                                    </div>

                                    <button type="submit">Enviar</button>
                                </form>

                            </div>
                        </section>

                        <section className="lista_pizzarias">
                            <div>
                                <h2>Pizzarias</h2>
                                <table className="table__pizzarias">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Nome</th>
                                            <th>Endereço</th>
                                            <th>Telefone</th>
                                            <th>Opcao Vegana</th>
                                            <th>Categoria</th>
                                        </tr>
                                    </thead>
                                    <tbody style={{ textAlign: "center" }}>
                                        {
                                            this.state.lista.map(function (pizzarias) {
                                                return (
                                                    <tr key={pizzarias.id}>
                                                        <td>{pizzarias.id}</td>
                                                        <td>{pizzarias.nome}</td>
                                                        <td>{pizzarias.endereco}</td>
                                                        <td>{pizzarias.telefone}</td>
                                                        <td>{pizzarias.opcaoVegana.toString()}</td>
                                                        <td>{pizzarias.idCategoriaNavigation.nome + " = " + pizzarias.idCategoriaNavigation.valor}</td>
                                                    </tr>
                                                )
                                            })
                                        }
                                    </tbody>
                                </table>
                            </div>
                        </section>
                    </div>
                </div>
            </main>
        )
    }
}

export default Pizzaria;