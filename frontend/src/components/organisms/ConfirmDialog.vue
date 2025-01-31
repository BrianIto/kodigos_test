<script lang="ts" setup>
import { defineProps, defineEmits, computed, ref } from "vue";
import Button from "../atoms/Button.vue";

let props = defineProps<{
  title: string;
  description: string;
  show: boolean;
}>();

const dialog = ref(null);

const open = () => {
  dialog.value.showModal();
};

const close = () => {
  dialog.value.close();
};

let emit = defineEmits(['approve', 'repprove']);

defineExpose({ open, close });
</script>

<template>
  <dialog ref="dialog" class="w-2xl mx-auto mt-36 px-8 py-5 rounded-lg">
    <h1
      class="text-xl font-medium border-b pb-3 text-zinc-700 mb-3 border-zinc-300"
    >
      {{ props.title }}
    </h1>
    <p class="text-sm font-light text-zinc-700 my-5">{{ props.description }}</p>
    <div class="flex gap-4 justify-end">
      <Button type="nobg" @click="close">Retomar Edição</Button>
      <Button @click="emit('repprove')" type="secondary">Reprovar</Button>
      <Button @click="emit('approve')">Aprovar</Button>
    </div>
  </dialog>
</template>

<style scoped>
dialog::backdrop {
  backdrop-filter: blur(4.5px);

  background-color: rgba(0, 0, 0, 0.5);
}
</style>
