<script setup lang="ts">
import { defineProps, defineEmits, computed } from "vue";

let { type = "primary" } = defineProps<{
  type: "primary" | "secondary" | "nobg";
}>();

const buttonClasses = computed(() => {
  const baseClasses =
    "bg-blue-400 px-5 py-2.5 flex gap-3 items-center font-semibold text-white rounded-lg  cursor-pointer duration-200";
  return (
    baseClasses +
    " " +
    (type === "primary"
      ? "bg-blue-400 hover:bg-blue-500"
      : type === "secondary"
        ? "border border-blue-400 bg-transparent !text-blue-400 text-blue-400 hover:-translate-y-0.5"
        : "text-zinc-300 !bg-transparent font-light hover:text-zinc-500")
  );
});
</script>

<template>
  <button :class="buttonClasses">
    <slot></slot>
  </button>
</template>
