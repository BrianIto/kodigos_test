<script setup lang="ts">
import { defineProps, defineEmits, computed } from "vue";
import { BeakerIcon } from "@heroicons/vue/24/outline";

const props = defineProps({
  icon: {
    type: Function,
    required: true,
    default: BeakerIcon,
  },
  active: {
    type: Boolean,
    default: false,
  },
});

const emit = defineEmits(['click']);

const buttonClasses = computed(() => [
  "p-3 rounded-lg hover:text-blue-400 enabled:cursor-pointer flex items-center justify-center" +
    " hover:enabled:bg-zinc-100 disabled:opacity-50 bg-transparent group duration-200",
  props.active ? "active" : "",
]);

</script>

<template>
	<button :class="buttonClasses" @click="emit('click')" :disabled="disabled">
    <component
      :is="icon"
      class="w-6 group-[.active]:text-blue-400 text-zinc-400"
    />
  </button>
</template>
