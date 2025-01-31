<script setup lang="ts">
import Breadcrumbs from "../../atoms/Breadcrumbs.vue";
import InputText from "../../atoms/InputText.vue";

const breadcrumbs = [
  { title: "Cotações", href: "#" },
  { title: "Análise de Valores", href: "#" },
];
</script>
<template>
  <Breadcrumbs :elements="breadcrumbs" />
  <h1 class="text-3xl text-zinc-700 mt-1 mb-3 font-medium">
    Análise de Valores
  </h1>
  <div class="mt-1 w-full grid lg:grid-cols-12 md:grid-cols-3 gap-3 pr-3">
    <div class="xl:col-span-2 lg:col-span-3">
      <InputText label="Código" placeholder="0000" />
    </div>

    <div class="lg:col-span-3">
      <InputText label="Descrição" placeholder="Conforme escrito no produto" />
    </div>

    <div class="lg:col-span-3">
      <InputText label="Tipo" placeholder="O tipo do Produto" />
    </div>
  </div>
</template>
