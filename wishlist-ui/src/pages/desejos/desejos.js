import { Component } from 'react';

class desejos extends Component{
    constructor(props){
        //Permite que a gente referencie o this
        super(props);
        this.state = {
            listaDesejos : [],
            novoDesejo : ''
        }
    }

    componentDidMount(){

    }

    render(){
        return(
            <div>
                <main>
                    <section>
                        {/* Lista os desejos */}
                        <h2>Lista de desejos</h2>
                        <table>
                            <thead>
                                <tr>
                                    <th>#</th> {/* ID */}
                                    <th>Desejos</th> {/* Desejos */}
                                </tr>
                            </thead>

                            <tbody>
                                {
                                    this.state.listaDesejos.map( (listaDesejo) => {
                                        return(
                                            <tr key={listaDesejo.desejoId}>
                                                <td>{listaDesejo.desejoId}</td>
                                                <td>{listaDesejo.titulo}</td>
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