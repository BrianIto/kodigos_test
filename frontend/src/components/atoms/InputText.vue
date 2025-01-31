<script setup lang="ts">
import { defineProps, defineEmits } from "vue";
const { label, ...props } = defineProps<{
  label: string;
  placeholder: string;
}>();

let emit = defineEmits(["update:modelValue"]);
</script>

<template>
  <label
    class="group border border-zinc-200 text-sm gap-3 w-full flex rounded-lg focus-within:ring focus-within:ring-cyan-100 bg-white pr-2 duration-200"
  >
    <div v-if="label"
      class="border-r border-zinc-200 group-focus-within:border-cyan-100 group-focus-within:bg-cyan-50 rounded-l-lg bg-opacity-5 duration-200 flex items-center"
    >
    <span 
        class="text-zinc-500 group-focus-within:text-cyan-600 duration-200 py-2 px-5"
        >{{ label }}</span
      >
    </div>
    <input
      v-bind="props"
      @input="emit('update:modelValue', $event.target.value)"
      class="placeholder-zinc-300 flex-1 bg-white outline-none py-2 first:!py-1 first:px-2 first:text-right w-full text-zinc-700"
    />
  </label>
</template>
