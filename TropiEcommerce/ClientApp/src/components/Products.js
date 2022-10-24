import React, { Component } from 'react';

export class Product extends Component {
    constructor(props) {
        super(props);
        this.state = { products: [], loading: true };
    }
    componentDidMount() {
        this.populateProductData();
    }
    static renderProductsTable(products) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Price</th>
                    </tr>
                </thead>
                <tbody>
                    {products.map(product =>
                        <tr>
                            <td>{product.name}</td>
                            <td>{product.price}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }
    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Product.renderProductsTable(this.state.products);

        return (
            <div>
                <h1 id="tabelLabel" >Products</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
    async populateProductData() {
        const response = await fetch('product');
        const data = await response.json();
        console.log(data);
        this.setState({ products: data, loading: false });
    }
}