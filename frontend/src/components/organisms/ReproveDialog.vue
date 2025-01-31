<script setup lang="ts">
import { ref, defineExpose, defineEmits } from "vue";
import InputText from "../atoms/InputText.vue";
import Button from "../atoms/Button.vue";

const dialog = ref(null);
const emit = defineEmits(["cancel", "confirm"]);

const open = () => {
  dialog.value.showModal();
};

const close = () => {
  dialog.value.close();
};

const formData = ref({
  codigo: "",
  tipo: "",
  descricao: "",
  justificativa: "",
});

const handleSubmit = () => {
	emit('confirm', formData.value);
}

defineExpose({ open, close });
</script>

<template>
  <dialog ref="dialog" class="w-2xl mx-auto mt-36 px-8 py-5 rounded-lg">
    <h1
      class="text-xl font-medium border-b pb-3 text-zinc-700 mb-3 border-zinc-300"
    >
      Reprovar
    </h1>
    <form class="mt-6 flex flex-col gap-4">
      <div class="flex gap-3">
        <InputText
          v-model="formData.codigo"
          label="Código"
          placeholder="0000"
        />
        <InputText
          v-model="formData.tipo"
          label="Tipo"
          placeholder="Descrição do Material"
        />
      </div>
      <InputText
        v-model="formData.descricao"
        label="Descrição"
        placeholder="Descrição do Material"
      />
      <h2 class="font-medium text-zinc-600">Justificativa</h2>
      <InputText
        v-model="formData.justificativa"
        label="Justificativa"
        placeholder="Justificativa da Reprovação"
      />
      <div class="flex mt-3 justify-between">
        <Button @click="dialog.close()" type="nobg">Cancelar</Button>
        <Button @click="handleSubmit" type="primary"
          >Confirmar</Button
        >
      </div>
    </form>
  </dialog>
</template>

<style scoped>
dialog::backdrop {
  backdrop-filter: blur(4.5px);
  background-color: rgba(0, 0, 0, 0.5);
}
</style>
