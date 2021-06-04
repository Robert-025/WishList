import { Component } from 'react';

class desejos extends Component {
    constructor(props) {
        //Permite que a gente referencie o this
        super(props);
        this.state = {
            listaDesejos: [],
            novoDesejo: ''
        }
    }

    buscarDesejo = () => {
        console.log('Agora chamamos a API');

        //Faz a chamada para a API
        fetch('http://localhost:5000/api/Desejo')

            //Fetch retorna uma Promise que se resolve em uma resposta (Response)
            // .then(resposta => console.log(resposta.json()))

            //Define que a resposta da requisição será em formato JSON
            .then(resposta => resposta.json())

            //E atualiza o state listaDesejos com os dados obtidos
            .then(dados => this.setState({ listaDesejos: dados }))

            //Caso ocorra algum erro mostra no console do navegador
            .catch((erro) => console.log(erro));
    };

    componentDidMount() {
        this.buscarDesejo();
    };

    render() {
        return (
            <div>
                <main>
                    <section>
                        {/* Lista os desejos */}
                        <h2>Lista de desejos</h2>
                        <table>
                            <thead>
                                <tr>
                                    <th>#</th>{/* ID */}
                                    <th>Desejos</th>{/* Desejos */}
                                </tr>
                            </thead>

                            <tbody>
                                {
                                    this.state.listaDesejos.map((listaDesejo) => {
                                        return (
                                            <tr key={listaDesejo.idDesejo}>
                                                <td>{listaDesejo.idDesejo}</td>
                                                <td>{listaDesejo.descricao}</td>
                                            </tr>
                                        )
                                    })
                                }
                            </tbody>
                        </table>
                    </section>
                </main>
            </div>
        )
    }
}

export default desejos;