<script lang="ts" setup>
import { defineProps, defineEmits, ref, onMounted } from "vue";
import { XCircleIcon } from "@heroicons/vue/24/outline";
import { CheckIcon } from "@heroicons/vue/24/outline";

const { message, type } = defineProps<{
  message: string;
  type: "success" | "error";
}>();

let emit = defineEmits(["close"]);

const visible = ref(true);

onMounted(() => {
  setTimeout(() => {
    emit("close");
  }, 3000);
});
</script>

<template>
  <section
    class="fixed z-50 bg-green-100 text-green-500 border-l-3 border-l-green-500 min-w-64 flex items-center right-16 top-20 px-5 pr-12 gap-6 rounded-lg py-5"
  >
    <CheckIcon
      v-if="type === 'success'"
      class="w-6 text-green-400 inline-block"
    />
    <XCircleIcon
      v-if="type === 'error'"
      class="w-6 text-red-400 inline-block"
    />
    <p>{{ message }}</p>
  </section>
</template>
