<script setup lang="ts">
import Home from "./components/pages/Home.vue";
import ProductService, { Product } from "./services/ProductService";
import ValueAnalysisService, {
  ValueAnalysis,
} from "./services/ValueAnalysisService";
import { onMounted, ref } from "vue";

let products = ref<Product[]>([]);
let valueAnalysis = ref<ValueAnalysis[]>([]);

const productsService = ProductService();
const valueAnalysisService = ValueAnalysisService();

onMounted(() => {
  productsService.getAll().then((v) => {
    products.value = v;
  });
  valueAnalysisService.get().then((v) => {
    valueAnalysis.value = v;
  });
});
</script>

<template>
  <Home :products="products" :valueAnalysis="valueAnalysis" />
</template>
