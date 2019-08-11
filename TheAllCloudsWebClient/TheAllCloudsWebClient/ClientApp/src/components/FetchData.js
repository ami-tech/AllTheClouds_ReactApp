import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor (props) {
    super(props);
    this.state = { products: [], loading: true };

    fetch('api/AllTheClouds/Products')
      .then(response => response.json())
      .then(data => {
        this.setState({ products: data, loading: false });
      });
  }

  static renderProductsTable (products) {
    return (
      <table className='table table-striped'>
        <thead>
          <tr>
                    <th>Name</th>
                    <th>Description</th>
                    <th>Unit Price</th>                    
          </tr>
        </thead>
        <tbody>
                {products.map(product =>
                    <tr key={product.productId} id={product.productId}>
                        <td>{product.name}</td>
                        <td>{product.description}</td>
                        <td>{product.unitPrice}</td>                        
                    </tr>
                )}
        </tbody>
      </table>
    );
  }

  render () {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : FetchData.renderProductsTable(this.state.products);

    return (
      <div>
        <h1>Products</h1>
        <p>This List of Available products and their prices.</p>
        {contents}
      </div>
    );
  }
}
