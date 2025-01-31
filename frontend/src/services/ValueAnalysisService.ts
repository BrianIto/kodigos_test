import type { Product } from "./ProductService";
import type { Supplier } from "./SupplierService";

export interface ValueAnalysis {
  id: number;
  products: Product[];
  suppliers: Supplier[];
  status: "Pending" | "Approved" | "Reproved";
}

const ValueAnalysis = () => {
  return {
    /**
     * This is to get all value analysis
     * @returns All value analysis
     */
    async get() {
      try {
        let res = await fetch("http://localhost:8082/api/ValueAnalysis", {
          headers: { "Content-Type": "application/json" },
        });
        return await res.json();
      } catch (e) {
        return e;
      }
    },
    /** This is to approve a value analysis
     * @param id - The id of the value analysis
     * @returns The value analysis approved
     */
    async approve(id: number) {
      try {
        let res = await fetch(
          "http://localhost:8082/api/ValueAnalysis/approve?id=" + id,
          {
            headers: { "Content-Type": "application/json" },
          },
        );
        return await res.json();
      } catch (e) {
        return e;
      }
    },
    async reprove() {},
  };
};

export default ValueAnalysis;
