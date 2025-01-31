export interface Product {
	id: number;
	name: string;
	description: string;
	amount: number;
}

const ProductService = () => {
  return {
    async getAll() {
      try {
        let res = await fetch("http://localhost:8082/api/Product", {
          headers: { "Content-Type": "application/json" },
        });
        return await res.json();
      } catch (e) {
        return e;
      }
    },
  };
};

export default ProductService;
