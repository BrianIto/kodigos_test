<script setup lang="ts">
import { defineProps, defineEmits, computed } from "vue";
import {
  PlusIcon,
  CloudArrowUpIcon,
  XCircleIcon,
} from "@heroicons/vue/24/outline";
import Button from "../atoms/Button.vue";
</script>

<template>
  <div class="flex gap-3 mt-6 mb-3 bg-zinc-50 p-5 px-8 rounded-2xl">
    <Button type="primary"> <PlusIcon class="w-5 -ml-2" /> Adicionar </Button>
    <Button type="secondary">
      <CloudArrowUpIcon class="w-6 -ml-2" /> Upload
    </Button>
    <Button type="nobg">Cancelar</Button>
  </div>
  <div
    class="grid grid-cols-3 text-zinc-700 font-light text-sm text-center border py-3 px-6 rounded-lg border-zinc-100"
  >
    <div>Cotação Fornecedor A</div>
    <div>14.323kb</div>
    <div class="text-right flex gap-3 items-center justify-end pr-12">
      <button class="group flex gap-3 items-center cursor-pointer">
        <span class="group-hover:opacity-30 opacity-0 duration-300"
          >Remover </span
        ><XCircleIcon class="w-6 text-red-400 inline-block" />
      </button>
    </div>
  </div>
</template>
